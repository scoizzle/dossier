# Fact 54f9db2a

Store id: 0badc15a-1c39-4ad2-98b4-5ab35bf18f3b

## Text

```text
class BinaryField(Field)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:31:56.8401040+00:00`

## Data

```json
{
  "end_line": 2816,
  "entity_kind": "class",
  "parent": "__init__",
  "start_line": 2744,
  "symbol": "BinaryField"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2744,"selector":"L2744-L2816","symbol":"BinaryField"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::BinaryField](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2816,
    "entity_kind": "class",
    "parent": "__init__",
    "start_line": 2744,
    "symbol": "BinaryField"
  },
  "id": "0badc15a-1c39-4ad2-98b4-5ab35bf18f3b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.8401040+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2744,
        "selector": "L2744-L2816",
        "symbol": "BinaryField"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "87f170a2-dea3-4a40-a580-06f31acb6333",
  "subject_name": "django/db/models/fields/__init__::BinaryField",
  "tags": [
    "entity:class"
  ],
  "text": "class BinaryField(Field)"
}
```
