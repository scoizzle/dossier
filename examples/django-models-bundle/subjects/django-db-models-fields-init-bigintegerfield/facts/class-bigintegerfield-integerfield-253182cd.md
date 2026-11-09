# Fact 253182cd

Store id: 404d3140-96ff-4aa9-a072-e828f6c8ea9f

## Text

```text
class BigIntegerField(IntegerField)
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
- posted_at: `2026-11-09T22:39:42.5465690+00:00`

## Data

```json
{
  "end_line": 2255,
  "entity_kind": "class",
  "parent": "__init__",
  "start_line": 2241,
  "symbol": "BigIntegerField"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2241,"selector":"L2241-L2255","symbol":"BigIntegerField"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::BigIntegerField](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2255,
    "entity_kind": "class",
    "parent": "__init__",
    "start_line": 2241,
    "symbol": "BigIntegerField"
  },
  "id": "404d3140-96ff-4aa9-a072-e828f6c8ea9f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.5465690+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2241,
        "selector": "L2241-L2255",
        "symbol": "BigIntegerField"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "0188fa61-1737-436e-8b11-bae6b7fece1e",
  "subject_name": "django/db/models/fields/__init__::BigIntegerField",
  "tags": [
    "entity:class"
  ],
  "text": "class BigIntegerField(IntegerField)"
}
```
