# Fact 21c0a171

Store id: 082b610e-897b-4275-b7f7-aaace3fb4b84

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
- posted_at: `2026-11-09T23:44:56.1467670+00:00`

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
  "id": "082b610e-897b-4275-b7f7-aaace3fb4b84",
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
    "posted_at": "2026-11-09T23:44:56.1467670+00:00"
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
  "subject_id": "08070c61-5c0b-4490-9cd2-382637e0d3ce",
  "subject_name": "django/db/models/query::QuerySet._avoid_cloning",
  "tags": [
    "entity:method"
  ],
  "text": "def _avoid_cloning(self)"
}
```
