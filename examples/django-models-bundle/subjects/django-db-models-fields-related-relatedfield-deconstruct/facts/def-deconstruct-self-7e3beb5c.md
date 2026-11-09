# Fact 7e3beb5c

Store id: ec2f6c7d-b0c3-4006-97d8-5403b7aac547

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
- posted_at: `2026-11-09T23:44:51.4822030+00:00`

## Data

```json
{
  "end_line": 417,
  "entity_kind": "method",
  "parent": "RelatedField",
  "start_line": 409,
  "symbol": "RelatedField.deconstruct"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":409,"selector":"L409-L417","symbol":"RelatedField.deconstruct"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::RelatedField.deconstruct](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 417,
    "entity_kind": "method",
    "parent": "RelatedField",
    "start_line": 409,
    "symbol": "RelatedField.deconstruct"
  },
  "id": "ec2f6c7d-b0c3-4006-97d8-5403b7aac547",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.4822030+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 409,
        "selector": "L409-L417",
        "symbol": "RelatedField.deconstruct"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "aa6b4ad7-b988-49f8-959f-df42b93bfd0a",
  "subject_name": "django/db/models/fields/related::RelatedField.deconstruct",
  "tags": [
    "entity:method"
  ],
  "text": "def deconstruct(self)"
}
```
