# Fact 3e7d1a3a

Store id: 3028e020-098d-4050-b482-32b08a148c00

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
- posted_at: `2026-11-09T23:31:56.5718000+00:00`

## Data

```json
{
  "end_line": 1425,
  "entity_kind": "method",
  "parent": "DateTimeCheckMixin",
  "start_line": 1424,
  "symbol": "DateTimeCheckMixin._check_fix_default_value"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1424,"selector":"L1424-L1425","symbol":"DateTimeCheckMixin._check_fix_default_value"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::DateTimeCheckMixin._check_fix_default_value](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1425,
    "entity_kind": "method",
    "parent": "DateTimeCheckMixin",
    "start_line": 1424,
    "symbol": "DateTimeCheckMixin._check_fix_default_value"
  },
  "id": "3028e020-098d-4050-b482-32b08a148c00",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.5718000+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1424,
        "selector": "L1424-L1425",
        "symbol": "DateTimeCheckMixin._check_fix_default_value"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "9e4e799f-a0f5-4f3a-a8ce-74ab9292adfb",
  "subject_name": "django/db/models/fields/__init__::DateTimeCheckMixin._check_fix_default_value",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_fix_default_value(self)"
}
```
