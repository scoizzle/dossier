# Fact 04c887a2

Store id: a23b7441-e544-4ec9-87ac-9a0289f2234a

## Text

```text
def deconstruct(self)
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
- posted_at: `2026-11-09T23:31:57.6410500+00:00`

## Data

```json
{
  "end_line": 198,
  "entity_kind": "method",
  "parent": "GeneratedField",
  "start_line": 191,
  "symbol": "GeneratedField.deconstruct"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/generated.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":191,"selector":"L191-L198","symbol":"GeneratedField.deconstruct"}`

## Referenced by

None.

## Subject

[django/db/models/fields/generated::GeneratedField.deconstruct](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 198,
    "entity_kind": "method",
    "parent": "GeneratedField",
    "start_line": 191,
    "symbol": "GeneratedField.deconstruct"
  },
  "id": "a23b7441-e544-4ec9-87ac-9a0289f2234a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.6410500+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 191,
        "selector": "L191-L198",
        "symbol": "GeneratedField.deconstruct"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/generated.py"
    }
  ],
  "status": "live",
  "subject_id": "f05d3f0f-0bde-433e-b094-923955cf217f",
  "subject_name": "django/db/models/fields/generated::GeneratedField.deconstruct",
  "tags": [
    "entity:method"
  ],
  "text": "def deconstruct(self)"
}
```
