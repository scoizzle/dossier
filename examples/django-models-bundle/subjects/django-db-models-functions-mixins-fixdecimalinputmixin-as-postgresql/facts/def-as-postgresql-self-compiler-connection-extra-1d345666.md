# Fact 1d345666

Store id: a71485ef-30c6-48c2-b236-d768d6ee5d63

## Text

```text
def as_postgresql(self, compiler, connection, **extra_context)
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
- posted_at: `2026-11-09T23:32:01.9395310+00:00`

## Data

```json
{
  "end_line": 25,
  "entity_kind": "method",
  "parent": "FixDecimalInputMixin",
  "start_line": 8,
  "symbol": "FixDecimalInputMixin.as_postgresql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/mixins.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":8,"selector":"L8-L25","symbol":"FixDecimalInputMixin.as_postgresql"}`

## Referenced by

None.

## Subject

[django/db/models/functions/mixins::FixDecimalInputMixin.as_postgresql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 25,
    "entity_kind": "method",
    "parent": "FixDecimalInputMixin",
    "start_line": 8,
    "symbol": "FixDecimalInputMixin.as_postgresql"
  },
  "id": "a71485ef-30c6-48c2-b236-d768d6ee5d63",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:01.9395310+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 8,
        "selector": "L8-L25",
        "symbol": "FixDecimalInputMixin.as_postgresql"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/mixins.py"
    }
  ],
  "status": "live",
  "subject_id": "87c453d2-5fbd-4272-8374-84be69a7453e",
  "subject_name": "django/db/models/functions/mixins::FixDecimalInputMixin.as_postgresql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_postgresql(self, compiler, connection, **extra_context)"
}
```
