# Fact 21c0a171

Store id: ada3ca83-6dc7-40c3-84b7-b47ee7afc378

## Text

```text
def _avoid_cloning(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:32:04.6340150+00:00`

## Data

```json
{
  "end_line": 2245,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 2235,
  "symbol": "QuerySet._avoid_cloning"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2235,"selector":"L2235-L2245","symbol":"QuerySet._avoid_cloning"}`

## Items

```json
[
  {
    "text": "Temporarily prevent QuerySet _clone() operations, restoring the default behavior on exit. For the duration of the context managed statement, all operations (e.g. filter(), exclude(), etc.) will mutate the same QuerySet instance.",
    "locator": {
      "line": 2236
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet._avoid_cloning](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2245,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 2235,
    "symbol": "QuerySet._avoid_cloning"
  },
  "id": "ada3ca83-6dc7-40c3-84b7-b47ee7afc378",
  "items": [
    {
      "locator": {
        "line": 2236
      },
      "text": "Temporarily prevent QuerySet _clone() operations, restoring the default behavior on exit. For the duration of the context managed statement, all operations (e.g. filter(), exclude(), etc.) will mutate the same QuerySet instance."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.6340150+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2235,
        "selector": "L2235-L2245",
        "symbol": "QuerySet._avoid_cloning"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "1a6f1120-5230-44b2-bc68-f272a131d894",
  "subject_name": "django/db/models/query::QuerySet._avoid_cloning",
  "tags": [
    "entity:method"
  ],
  "text": "def _avoid_cloning(self)"
}
```
