# Fact 74263ac5

Store id: a0dca88c-7b56-4d09-82b7-76e66b5fe8f5

## Text

```text
def __mod__(self, other)
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
- posted_at: `2026-11-09T23:31:55.7294150+00:00`

## Data

```json
{
  "end_line": 92,
  "entity_kind": "method",
  "parent": "Combinable",
  "start_line": 91,
  "symbol": "Combinable.__mod__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":91,"selector":"L91-L92","symbol":"Combinable.__mod__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Combinable.__mod__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 92,
    "entity_kind": "method",
    "parent": "Combinable",
    "start_line": 91,
    "symbol": "Combinable.__mod__"
  },
  "id": "a0dca88c-7b56-4d09-82b7-76e66b5fe8f5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.7294150+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 91,
        "selector": "L91-L92",
        "symbol": "Combinable.__mod__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "b388f5f0-7845-458a-a697-9da3e7ec2336",
  "subject_name": "django/db/models/expressions::Combinable.__mod__",
  "tags": [
    "entity:method"
  ],
  "text": "def __mod__(self, other)"
}
```
