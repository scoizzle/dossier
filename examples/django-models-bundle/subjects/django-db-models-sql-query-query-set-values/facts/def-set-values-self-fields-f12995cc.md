# Fact f12995cc

Store id: 851702d7-c879-4ad5-af46-a04266accc01

## Text

```text
def set_values(self, fields)
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
- posted_at: `2026-11-09T22:39:51.5400780+00:00`

## Data

```json
{
  "end_line": 2660,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 2587,
  "symbol": "Query.set_values"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2587,"selector":"L2587-L2660","symbol":"Query.set_values"}`

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.set_values](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2660,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 2587,
    "symbol": "Query.set_values"
  },
  "id": "851702d7-c879-4ad5-af46-a04266accc01",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.5400780+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2587,
        "selector": "L2587-L2660",
        "symbol": "Query.set_values"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "e4274291-5744-48a0-ae07-821f91301305",
  "subject_name": "django/db/models/sql/query::Query.set_values",
  "tags": [
    "entity:method"
  ],
  "text": "def set_values(self, fields)"
}
```
