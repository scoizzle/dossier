# Fact 8f4a13b0

Store id: 6e3b657d-2e93-4177-b25d-6d0384383231

## Text

```text
def get_pk_value_on_save(self, instance)
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
- posted_at: `2026-11-09T23:44:50.4943380+00:00`

## Data

```json
{
  "end_line": 127,
  "entity_kind": "method",
  "parent": "CompositePrimaryKey",
  "start_line": 118,
  "symbol": "CompositePrimaryKey.get_pk_value_on_save"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/composite.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":118,"selector":"L118-L127","symbol":"CompositePrimaryKey.get_pk_value_on_save"}`

## Referenced by

None.

## Subject

[django/db/models/fields/composite::CompositePrimaryKey.get_pk_value_on_save](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 127,
    "entity_kind": "method",
    "parent": "CompositePrimaryKey",
    "start_line": 118,
    "symbol": "CompositePrimaryKey.get_pk_value_on_save"
  },
  "id": "6e3b657d-2e93-4177-b25d-6d0384383231",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.4943380+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 118,
        "selector": "L118-L127",
        "symbol": "CompositePrimaryKey.get_pk_value_on_save"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/composite.py"
    }
  ],
  "status": "live",
  "subject_id": "a2f8c435-89f0-4149-9956-cc3248d39975",
  "subject_name": "django/db/models/fields/composite::CompositePrimaryKey.get_pk_value_on_save",
  "tags": [
    "entity:method"
  ],
  "text": "def get_pk_value_on_save(self, instance)"
}
```
