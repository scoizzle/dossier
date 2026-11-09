# Fact 2c9111cc

Store id: 616a4bc1-c5ec-4b45-b6c9-d0c667a1bc89

## Text

```text
def as_mysql(self, compiler, connection, **extra_context)
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
- posted_at: `2026-11-09T23:32:01.9468690+00:00`

## Data

```json
{
  "end_line": 33,
  "entity_kind": "method",
  "parent": "FixDurationInputMixin",
  "start_line": 29,
  "symbol": "FixDurationInputMixin.as_mysql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/mixins.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":29,"selector":"L29-L33","symbol":"FixDurationInputMixin.as_mysql"}`

## Referenced by

None.

## Subject

[django/db/models/functions/mixins::FixDurationInputMixin.as_mysql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 33,
    "entity_kind": "method",
    "parent": "FixDurationInputMixin",
    "start_line": 29,
    "symbol": "FixDurationInputMixin.as_mysql"
  },
  "id": "616a4bc1-c5ec-4b45-b6c9-d0c667a1bc89",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:01.9468690+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 29,
        "selector": "L29-L33",
        "symbol": "FixDurationInputMixin.as_mysql"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/mixins.py"
    }
  ],
  "status": "live",
  "subject_id": "8e67f252-2ceb-444b-8c55-c896f9992655",
  "subject_name": "django/db/models/functions/mixins::FixDurationInputMixin.as_mysql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_mysql(self, compiler, connection, **extra_context)"
}
```
