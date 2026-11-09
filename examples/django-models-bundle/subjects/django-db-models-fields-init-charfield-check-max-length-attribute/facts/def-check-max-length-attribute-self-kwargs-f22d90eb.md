# Fact f22d90eb

Store id: c01090e3-a638-450a-b825-fa8863c64574

## Text

```text
def _check_max_length_attribute(self, **kwargs)
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
- posted_at: `2026-11-09T23:44:50.0625050+00:00`

## Data

```json
{
  "end_line": 1296,
  "entity_kind": "method",
  "parent": "CharField",
  "start_line": 1268,
  "symbol": "CharField._check_max_length_attribute"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1268,"selector":"L1268-L1296","symbol":"CharField._check_max_length_attribute"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::CharField._check_max_length_attribute](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1296,
    "entity_kind": "method",
    "parent": "CharField",
    "start_line": 1268,
    "symbol": "CharField._check_max_length_attribute"
  },
  "id": "c01090e3-a638-450a-b825-fa8863c64574",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.0625050+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1268,
        "selector": "L1268-L1296",
        "symbol": "CharField._check_max_length_attribute"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "c9d8bc0e-a4a6-4117-b4c1-bd2d0804446f",
  "subject_name": "django/db/models/fields/__init__::CharField._check_max_length_attribute",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_max_length_attribute(self, **kwargs)"
}
```
