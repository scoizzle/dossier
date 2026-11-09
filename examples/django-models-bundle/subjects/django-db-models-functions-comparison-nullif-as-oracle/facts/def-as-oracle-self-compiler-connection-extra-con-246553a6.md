# Fact 246553a6

Store id: 7bc34c09-3494-4dd5-b85c-595c3abad31c

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
- posted_at: `2026-11-09T23:32:01.0132360+00:00`

## Data

```json
{
  "end_line": 173,
  "entity_kind": "method",
  "parent": "NullIf",
  "start_line": 169,
  "symbol": "NullIf.as_oracle"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/comparison.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":169,"selector":"L169-L173","symbol":"NullIf.as_oracle"}`

## Referenced by

None.

## Subject

[django/db/models/functions/comparison::NullIf.as_oracle](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 173,
    "entity_kind": "method",
    "parent": "NullIf",
    "start_line": 169,
    "symbol": "NullIf.as_oracle"
  },
  "id": "7bc34c09-3494-4dd5-b85c-595c3abad31c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:01.0132360+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 169,
        "selector": "L169-L173",
        "symbol": "NullIf.as_oracle"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/comparison.py"
    }
  ],
  "status": "live",
  "subject_id": "92c75e6b-1cc9-4684-8e8a-14bd1d3e67e4",
  "subject_name": "django/db/models/functions/comparison::NullIf.as_oracle",
  "tags": [
    "entity:method"
  ],
  "text": "def as_oracle(self, compiler, connection, **extra_context)"
}
```
