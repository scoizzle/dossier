# Fact e2791f66

Store id: 96468acd-3643-4b75-af3b-b5a7ad7f047d

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
- posted_at: `2026-11-09T23:31:56.7026530+00:00`

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
  "id": "96468acd-3643-4b75-af3b-b5a7ad7f047d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.7026530+00:00"
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
  "subject_id": "bb11c0c7-8043-4ba3-bfe8-85ead0711986",
  "subject_name": "django/db/models/fields/__init__::IntegerField.get_internal_type",
  "tags": [
    "entity:method"
  ],
  "text": "def get_internal_type(self)"
}
```
