# Fact 111ad01d

Store id: 8cdbb9e2-2913-49b7-851a-f606cfa24759

## Text

```text
def get_db_prep_value(self, value, connection, prepared=False)
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
- posted_at: `2026-11-09T23:44:50.3212240+00:00`

## Data

```json
{
  "end_line": 2909,
  "entity_kind": "method",
  "parent": "AutoFieldMixin",
  "start_line": 2908,
  "symbol": "AutoFieldMixin.get_db_prep_value"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2908,"selector":"L2908-L2909","symbol":"AutoFieldMixin.get_db_prep_value"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::AutoFieldMixin.get_db_prep_value](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2909,
    "entity_kind": "method",
    "parent": "AutoFieldMixin",
    "start_line": 2908,
    "symbol": "AutoFieldMixin.get_db_prep_value"
  },
  "id": "8cdbb9e2-2913-49b7-851a-f606cfa24759",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.3212240+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2908,
        "selector": "L2908-L2909",
        "symbol": "AutoFieldMixin.get_db_prep_value"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "e88ce5d5-a5c1-4fab-abcf-96967f339c69",
  "subject_name": "django/db/models/fields/__init__::AutoFieldMixin.get_db_prep_value",
  "tags": [
    "entity:method"
  ],
  "text": "def get_db_prep_value(self, value, connection, prepared=False)"
}
```
