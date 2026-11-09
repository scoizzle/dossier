# Fact a9c3071f

Store id: f615c859-0a5c-401f-9ae3-c7cfc51d5387

## Text

```text
def count(self)
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
- posted_at: `2026-11-09T23:32:04.3762540+00:00`

## Data

```json
{
  "end_line": 693,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 682,
  "symbol": "QuerySet.count"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":682,"selector":"L682-L693","symbol":"QuerySet.count"}`

## Items

```json
[
  {
    "text": "Perform a SELECT COUNT() and return the number of records as an integer.",
    "locator": {
      "line": 683
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.count](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 693,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 682,
    "symbol": "QuerySet.count"
  },
  "id": "f615c859-0a5c-401f-9ae3-c7cfc51d5387",
  "items": [
    {
      "locator": {
        "line": 683
      },
      "text": "Perform a SELECT COUNT() and return the number of records as an integer."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.3762540+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 682,
        "selector": "L682-L693",
        "symbol": "QuerySet.count"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "0bc9df4e-a311-4d11-99f9-40441839a54e",
  "subject_name": "django/db/models/query::QuerySet.count",
  "tags": [
    "entity:method"
  ],
  "text": "def count(self)"
}
```
