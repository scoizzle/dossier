# Fact 20f74f8b

Store id: e33391e4-7008-4de5-8545-39e555247e67

## Text

```text
def _check_fix_default_value(self)
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
- posted_at: `2026-11-09T22:39:42.4137930+00:00`

## Data

```json
{
  "end_line": 1504,
  "entity_kind": "method",
  "parent": "DateField",
  "start_line": 1487,
  "symbol": "DateField._check_fix_default_value"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1487,"selector":"L1487-L1504","symbol":"DateField._check_fix_default_value"}`

## Items

```json
[
  {
    "text": "Warn that using an actual date or datetime value is probably wrong; it's only evaluated on server startup.",
    "locator": {
      "line": 1488
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::DateField._check_fix_default_value](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1504,
    "entity_kind": "method",
    "parent": "DateField",
    "start_line": 1487,
    "symbol": "DateField._check_fix_default_value"
  },
  "id": "e33391e4-7008-4de5-8545-39e555247e67",
  "items": [
    {
      "locator": {
        "line": 1488
      },
      "text": "Warn that using an actual date or datetime value is probably wrong; it's only evaluated on server startup."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.4137930+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1487,
        "selector": "L1487-L1504",
        "symbol": "DateField._check_fix_default_value"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "a1ca3370-e30c-4bcc-805c-ca4855a694e1",
  "subject_name": "django/db/models/fields/__init__::DateField._check_fix_default_value",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_fix_default_value(self)"
}
```
