# Fact 54f9db2a

Store id: 8cd2ce0d-7cc5-474e-8ddc-08a2398340be

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
- posted_at: `2026-11-09T22:39:42.6864570+00:00`

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
  "id": "8cd2ce0d-7cc5-474e-8ddc-08a2398340be",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.6864570+00:00"
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
  "subject_id": "e3f96d27-c190-454a-a529-f233067a901b",
  "subject_name": "django/db/models/fields/__init__::BinaryField",
  "tags": [
    "entity:class"
  ],
  "text": "class BinaryField(Field)"
}
```
