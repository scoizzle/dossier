# Fact 2af22d77

Store id: 01b6993d-a054-4360-b7a5-9d38f6d5b45b

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
- posted_at: `2026-11-09T23:44:54.1725150+00:00`

## Data

```json
{
  "end_line": 367,
  "entity_kind": "method",
  "parent": "Substr",
  "start_line": 366,
  "symbol": "Substr.as_oracle"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/text.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":366,"selector":"L366-L367","symbol":"Substr.as_oracle"}`

## Referenced by

None.

## Subject

[django/db/models/functions/text::Substr.as_oracle](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 367,
    "entity_kind": "method",
    "parent": "Substr",
    "start_line": 366,
    "symbol": "Substr.as_oracle"
  },
  "id": "01b6993d-a054-4360-b7a5-9d38f6d5b45b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.1725150+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 366,
        "selector": "L366-L367",
        "symbol": "Substr.as_oracle"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/text.py"
    }
  ],
  "status": "live",
  "subject_id": "5583a5cf-fa4d-4b97-b93e-b3ff8c0777b8",
  "subject_name": "django/db/models/functions/text::Substr.as_oracle",
  "tags": [
    "entity:method"
  ],
  "text": "def as_oracle(self, compiler, connection, **extra_context)"
}
```
