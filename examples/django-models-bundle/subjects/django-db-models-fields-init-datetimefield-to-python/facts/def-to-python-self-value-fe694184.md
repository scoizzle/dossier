# Fact fe694184

Store id: d32eb696-bc39-42cb-bba3-012f823f7e77

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
- posted_at: `2026-11-09T23:31:56.5965600+00:00`

## Data

```json
{
  "end_line": 1688,
  "entity_kind": "method",
  "parent": "DateTimeField",
  "start_line": 1637,
  "symbol": "DateTimeField.to_python"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1637,"selector":"L1637-L1688","symbol":"DateTimeField.to_python"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::DateTimeField.to_python](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1688,
    "entity_kind": "method",
    "parent": "DateTimeField",
    "start_line": 1637,
    "symbol": "DateTimeField.to_python"
  },
  "id": "d32eb696-bc39-42cb-bba3-012f823f7e77",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.5965600+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1637,
        "selector": "L1637-L1688",
        "symbol": "DateTimeField.to_python"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "9f8472a3-b031-4f3a-9ae1-0a95a666ada7",
  "subject_name": "django/db/models/fields/__init__::DateTimeField.to_python",
  "tags": [
    "entity:method"
  ],
  "text": "def to_python(self, value)"
}
```
