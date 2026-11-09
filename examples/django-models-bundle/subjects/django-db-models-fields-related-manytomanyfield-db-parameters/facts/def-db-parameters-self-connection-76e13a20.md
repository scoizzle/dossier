# Fact 76e13a20

Store id: 2f9f3147-4c75-41b6-a867-0e9063f8d6bb

## Text

```text
def db_parameters(self, connection)
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
- posted_at: `2026-11-09T23:44:51.6859310+00:00`

## Data

```json
{
  "end_line": 2212,
  "entity_kind": "method",
  "parent": "ManyToManyField",
  "start_line": 2211,
  "symbol": "ManyToManyField.db_parameters"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2211,"selector":"L2211-L2212","symbol":"ManyToManyField.db_parameters"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ManyToManyField.db_parameters](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2212,
    "entity_kind": "method",
    "parent": "ManyToManyField",
    "start_line": 2211,
    "symbol": "ManyToManyField.db_parameters"
  },
  "id": "2f9f3147-4c75-41b6-a867-0e9063f8d6bb",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.6859310+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2211,
        "selector": "L2211-L2212",
        "symbol": "ManyToManyField.db_parameters"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "cc5112ef-542f-4663-940b-94f060a2ef71",
  "subject_name": "django/db/models/fields/related::ManyToManyField.db_parameters",
  "tags": [
    "entity:method"
  ],
  "text": "def db_parameters(self, connection)"
}
```
