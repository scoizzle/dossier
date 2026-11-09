# Fact 791fc545

Store id: d8e7b520-f5bc-4f37-8a52-428eecc6909a

## Text

```text
def to_python(self, value)
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
- posted_at: `2026-11-09T22:39:42.4180790+00:00`

## Data

```json
{
  "end_line": 1548,
  "entity_kind": "method",
  "parent": "DateField",
  "start_line": 1520,
  "symbol": "DateField.to_python"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1520,"selector":"L1520-L1548","symbol":"DateField.to_python"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::DateField.to_python](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1548,
    "entity_kind": "method",
    "parent": "DateField",
    "start_line": 1520,
    "symbol": "DateField.to_python"
  },
  "id": "d8e7b520-f5bc-4f37-8a52-428eecc6909a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.4180790+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1520,
        "selector": "L1520-L1548",
        "symbol": "DateField.to_python"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "399e581e-3593-4f21-a80c-bf31014f4176",
  "subject_name": "django/db/models/fields/__init__::DateField.to_python",
  "tags": [
    "entity:method"
  ],
  "text": "def to_python(self, value)"
}
```
