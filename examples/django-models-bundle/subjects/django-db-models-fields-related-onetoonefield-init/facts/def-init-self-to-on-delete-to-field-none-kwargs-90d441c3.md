# Fact 90d441c3

Store id: cf3b1fe1-81c2-42dd-8a78-a4ae72d20637

## Text

```text
def __init__(self, to, on_delete, to_field=None, **kwargs)
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
- posted_at: `2026-11-09T23:44:51.6155930+00:00`

## Data

```json
{
  "end_line": 1373,
  "entity_kind": "method",
  "parent": "OneToOneField",
  "start_line": 1371,
  "symbol": "OneToOneField.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1371,"selector":"L1371-L1373","symbol":"OneToOneField.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::OneToOneField.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1373,
    "entity_kind": "method",
    "parent": "OneToOneField",
    "start_line": 1371,
    "symbol": "OneToOneField.__init__"
  },
  "id": "cf3b1fe1-81c2-42dd-8a78-a4ae72d20637",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.6155930+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1371,
        "selector": "L1371-L1373",
        "symbol": "OneToOneField.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "2443f966-35e7-439d-b336-7f8347fc4d4e",
  "subject_name": "django/db/models/fields/related::OneToOneField.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, to, on_delete, to_field=None, **kwargs)"
}
```
