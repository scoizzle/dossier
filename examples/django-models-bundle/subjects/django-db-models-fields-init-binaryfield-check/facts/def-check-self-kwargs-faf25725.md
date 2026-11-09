# Fact faf25725

Store id: 079ea6b4-d041-4d50-b7a4-6ca5e53567cb

## Text

```text
def check(self, **kwargs)
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
- posted_at: `2026-11-09T23:44:50.2782510+00:00`

## Data

```json
{
  "end_line": 2758,
  "entity_kind": "method",
  "parent": "BinaryField",
  "start_line": 2757,
  "symbol": "BinaryField.check"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2757,"selector":"L2757-L2758","symbol":"BinaryField.check"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::BinaryField.check](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2758,
    "entity_kind": "method",
    "parent": "BinaryField",
    "start_line": 2757,
    "symbol": "BinaryField.check"
  },
  "id": "079ea6b4-d041-4d50-b7a4-6ca5e53567cb",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.2782510+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2757,
        "selector": "L2757-L2758",
        "symbol": "BinaryField.check"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "95ff2632-c607-4d20-aa99-b6d674400748",
  "subject_name": "django/db/models/fields/__init__::BinaryField.check",
  "tags": [
    "entity:method"
  ],
  "text": "def check(self, **kwargs)"
}
```
