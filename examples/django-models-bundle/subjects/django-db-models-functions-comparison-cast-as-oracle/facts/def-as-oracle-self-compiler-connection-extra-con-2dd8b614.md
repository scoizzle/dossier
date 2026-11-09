# Fact 2dd8b614

Store id: a68c2148-88c7-47cf-b13f-5f3d9eb4f240

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
- posted_at: `2026-11-09T22:39:45.9106550+00:00`

## Data

```json
{
  "end_line": 67,
  "entity_kind": "method",
  "parent": "Cast",
  "start_line": 60,
  "symbol": "Cast.as_oracle"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/comparison.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":60,"selector":"L60-L67","symbol":"Cast.as_oracle"}`

## Referenced by

None.

## Subject

[django/db/models/functions/comparison::Cast.as_oracle](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 67,
    "entity_kind": "method",
    "parent": "Cast",
    "start_line": 60,
    "symbol": "Cast.as_oracle"
  },
  "id": "a68c2148-88c7-47cf-b13f-5f3d9eb4f240",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:45.9106550+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 60,
        "selector": "L60-L67",
        "symbol": "Cast.as_oracle"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/comparison.py"
    }
  ],
  "status": "live",
  "subject_id": "50a3fa08-c9ea-4573-82c5-587d4d0ef863",
  "subject_name": "django/db/models/functions/comparison::Cast.as_oracle",
  "tags": [
    "entity:method"
  ],
  "text": "def as_oracle(self, compiler, connection, **extra_context)"
}
```
