# Fact 3e7d1a3a

Store id: b722460d-02d3-423d-a599-bc20ce0558b8

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
- posted_at: `2026-11-09T22:39:42.4067070+00:00`

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
  "id": "b722460d-02d3-423d-a599-bc20ce0558b8",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.4067070+00:00"
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
  "subject_id": "dcb0af66-cbc4-4a8e-8542-f22672568752",
  "subject_name": "django/db/models/fields/__init__::DateTimeCheckMixin._check_fix_default_value",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_fix_default_value(self)"
}
```
