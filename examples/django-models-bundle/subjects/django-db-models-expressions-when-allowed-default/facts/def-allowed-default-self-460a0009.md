# Fact 460a0009

Store id: 622b29c6-a372-4c18-b0c3-69c3915e0cc0

## Text

```text
def allowed_default(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:cached_property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:41.7016570+00:00`

## Data

```json
{
  "end_line": 1713,
  "entity_kind": "method",
  "parent": "When",
  "start_line": 1711,
  "symbol": "When.allowed_default"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1711,"selector":"L1711-L1713","symbol":"When.allowed_default"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::When.allowed_default](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1713,
    "entity_kind": "method",
    "parent": "When",
    "start_line": 1711,
    "symbol": "When.allowed_default"
  },
  "id": "622b29c6-a372-4c18-b0c3-69c3915e0cc0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.7016570+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1711,
        "selector": "L1711-L1713",
        "symbol": "When.allowed_default"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "fa1d9aec-0a2c-40cd-bdcc-f0541ded0a16",
  "subject_name": "django/db/models/expressions::When.allowed_default",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def allowed_default(self)"
}
```
