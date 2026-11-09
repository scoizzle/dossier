# Fact 2e2dc224

Store id: ef8ad285-6bbb-410e-b4cd-40a26de30d3f

## Text

```text
def get_db_prep_save(self, value, connection)
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
- posted_at: `2026-11-09T23:44:50.3231040+00:00`

## Data

```json
{
  "end_line": 2916,
  "entity_kind": "method",
  "parent": "AutoFieldMixin",
  "start_line": 2911,
  "symbol": "AutoFieldMixin.get_db_prep_save"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2911,"selector":"L2911-L2916","symbol":"AutoFieldMixin.get_db_prep_save"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::AutoFieldMixin.get_db_prep_save](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2916,
    "entity_kind": "method",
    "parent": "AutoFieldMixin",
    "start_line": 2911,
    "symbol": "AutoFieldMixin.get_db_prep_save"
  },
  "id": "ef8ad285-6bbb-410e-b4cd-40a26de30d3f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.3231040+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2911,
        "selector": "L2911-L2916",
        "symbol": "AutoFieldMixin.get_db_prep_save"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "69e512cd-b7e7-46fe-863e-8e2988859bd8",
  "subject_name": "django/db/models/fields/__init__::AutoFieldMixin.get_db_prep_save",
  "tags": [
    "entity:method"
  ],
  "text": "def get_db_prep_save(self, value, connection)"
}
```
