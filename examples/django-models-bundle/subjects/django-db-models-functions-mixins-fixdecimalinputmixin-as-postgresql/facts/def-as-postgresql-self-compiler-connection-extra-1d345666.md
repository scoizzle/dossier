# Fact 1d345666

Store id: 8f2a1092-52d3-4508-8ed7-d525c18357c1

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
- posted_at: `2026-11-09T23:44:53.8976330+00:00`

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
  "id": "8f2a1092-52d3-4508-8ed7-d525c18357c1",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:53.8976330+00:00"
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
  "subject_id": "df1b8ba4-4d9a-4fa8-9a9a-3b7103aec3e0",
  "subject_name": "django/db/models/functions/mixins::FixDecimalInputMixin.as_postgresql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_postgresql(self, compiler, connection, **extra_context)"
}
```
