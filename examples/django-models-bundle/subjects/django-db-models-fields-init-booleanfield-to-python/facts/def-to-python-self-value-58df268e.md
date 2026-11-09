# Fact 58df268e

Store id: 4303a482-c1ce-43be-a25a-5863631285c8

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
- posted_at: `2026-11-09T22:39:42.3678160+00:00`

## Data

```json
{
  "end_line": 1225,
  "entity_kind": "method",
  "parent": "BooleanField",
  "start_line": 1211,
  "symbol": "BooleanField.to_python"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1211,"selector":"L1211-L1225","symbol":"BooleanField.to_python"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::BooleanField.to_python](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1225,
    "entity_kind": "method",
    "parent": "BooleanField",
    "start_line": 1211,
    "symbol": "BooleanField.to_python"
  },
  "id": "4303a482-c1ce-43be-a25a-5863631285c8",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.3678160+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1211,
        "selector": "L1211-L1225",
        "symbol": "BooleanField.to_python"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "a66fb357-2ff4-4eec-97b8-bef2aa9abdef",
  "subject_name": "django/db/models/fields/__init__::BooleanField.to_python",
  "tags": [
    "entity:method"
  ],
  "text": "def to_python(self, value)"
}
```
