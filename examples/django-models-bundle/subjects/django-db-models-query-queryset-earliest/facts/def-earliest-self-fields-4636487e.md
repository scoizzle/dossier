# Fact 4636487e

Store id: 4beeab43-e480-4607-9b21-4cdf2efb025f

## Text

```text
def _earliest(self, *fields)
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
- posted_at: `2026-11-09T23:44:55.9379640+00:00`

## Data

```json
{
  "end_line": 1199,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 1179,
  "symbol": "QuerySet._earliest"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1179,"selector":"L1179-L1199","symbol":"QuerySet._earliest"}`

## Items

```json
[
  {
    "text": "Return the earliest object according to fields (if given) or by the model's Meta.get_latest_by.",
    "locator": {
      "line": 1180
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet._earliest](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1199,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 1179,
    "symbol": "QuerySet._earliest"
  },
  "id": "4beeab43-e480-4607-9b21-4cdf2efb025f",
  "items": [
    {
      "locator": {
        "line": 1180
      },
      "text": "Return the earliest object according to fields (if given) or by the model's Meta.get_latest_by."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.9379640+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1179,
        "selector": "L1179-L1199",
        "symbol": "QuerySet._earliest"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "74b870ba-54cf-4a04-a268-e8e8036602df",
  "subject_name": "django/db/models/query::QuerySet._earliest",
  "tags": [
    "entity:method"
  ],
  "text": "def _earliest(self, *fields)"
}
```
