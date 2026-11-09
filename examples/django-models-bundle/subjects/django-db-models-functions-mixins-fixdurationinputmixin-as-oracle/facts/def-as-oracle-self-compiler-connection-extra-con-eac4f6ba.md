# Fact eac4f6ba

Store id: c48452c1-dfc4-4d4f-bf7f-aedf3e1344d0

## Text

```text
def as_oracle(self, compiler, connection, **extra_context)
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
- posted_at: `2026-11-09T23:44:53.9047080+00:00`

## Data

```json
{
  "end_line": 52,
  "entity_kind": "method",
  "parent": "FixDurationInputMixin",
  "start_line": 35,
  "symbol": "FixDurationInputMixin.as_oracle"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/mixins.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":35,"selector":"L35-L52","symbol":"FixDurationInputMixin.as_oracle"}`

## Referenced by

None.

## Subject

[django/db/models/functions/mixins::FixDurationInputMixin.as_oracle](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 52,
    "entity_kind": "method",
    "parent": "FixDurationInputMixin",
    "start_line": 35,
    "symbol": "FixDurationInputMixin.as_oracle"
  },
  "id": "c48452c1-dfc4-4d4f-bf7f-aedf3e1344d0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:53.9047080+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 35,
        "selector": "L35-L52",
        "symbol": "FixDurationInputMixin.as_oracle"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/mixins.py"
    }
  ],
  "status": "live",
  "subject_id": "8f8d304d-ea86-485c-89c2-566677ac1af4",
  "subject_name": "django/db/models/functions/mixins::FixDurationInputMixin.as_oracle",
  "tags": [
    "entity:method"
  ],
  "text": "def as_oracle(self, compiler, connection, **extra_context)"
}
```
