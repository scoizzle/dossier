# Fact e2791f66

Store id: c09ba605-8ea7-4d4d-858c-921d6a5a9845

## Text

```text
def get_internal_type(self)
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
- posted_at: `2026-11-09T23:44:50.1659110+00:00`

## Data

```json
{
  "end_line": 2218,
  "entity_kind": "method",
  "parent": "IntegerField",
  "start_line": 2217,
  "symbol": "IntegerField.get_internal_type"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2217,"selector":"L2217-L2218","symbol":"IntegerField.get_internal_type"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::IntegerField.get_internal_type](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2218,
    "entity_kind": "method",
    "parent": "IntegerField",
    "start_line": 2217,
    "symbol": "IntegerField.get_internal_type"
  },
  "id": "c09ba605-8ea7-4d4d-858c-921d6a5a9845",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.1659110+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2217,
        "selector": "L2217-L2218",
        "symbol": "IntegerField.get_internal_type"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "5fada848-c84d-4fd2-ad7f-c6633ae10d4e",
  "subject_name": "django/db/models/fields/__init__::IntegerField.get_internal_type",
  "tags": [
    "entity:method"
  ],
  "text": "def get_internal_type(self)"
}
```
