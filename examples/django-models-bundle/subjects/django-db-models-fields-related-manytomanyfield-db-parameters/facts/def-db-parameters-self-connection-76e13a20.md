# Fact 76e13a20

Store id: dbb9abc8-a280-4851-a3b2-0724a1434c33

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
- posted_at: `2026-11-09T22:39:44.5190560+00:00`

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
  "id": "dbb9abc8-a280-4851-a3b2-0724a1434c33",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.5190560+00:00"
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
  "subject_id": "bb1477fe-271d-4d54-8252-ea025688e11e",
  "subject_name": "django/db/models/fields/related::ManyToManyField.db_parameters",
  "tags": [
    "entity:method"
  ],
  "text": "def db_parameters(self, connection)"
}
```
