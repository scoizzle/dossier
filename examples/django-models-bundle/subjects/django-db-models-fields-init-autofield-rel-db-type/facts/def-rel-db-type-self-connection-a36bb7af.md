# Fact a36bb7af

Store id: 05a46b18-8eeb-4658-a45a-629c7903f0c9

## Text

```text
def rel_db_type(self, connection)
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
- posted_at: `2026-11-09T22:39:42.7560100+00:00`

## Data

```json
{
  "end_line": 2968,
  "entity_kind": "method",
  "parent": "AutoField",
  "start_line": 2967,
  "symbol": "AutoField.rel_db_type"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2967,"selector":"L2967-L2968","symbol":"AutoField.rel_db_type"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::AutoField.rel_db_type](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2968,
    "entity_kind": "method",
    "parent": "AutoField",
    "start_line": 2967,
    "symbol": "AutoField.rel_db_type"
  },
  "id": "05a46b18-8eeb-4658-a45a-629c7903f0c9",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.7560100+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2967,
        "selector": "L2967-L2968",
        "symbol": "AutoField.rel_db_type"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "5f6ce468-8264-41ae-b1ea-9beaeaaa666b",
  "subject_name": "django/db/models/fields/__init__::AutoField.rel_db_type",
  "tags": [
    "entity:method"
  ],
  "text": "def rel_db_type(self, connection)"
}
```
