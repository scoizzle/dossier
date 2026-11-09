# Fact e47cbbae

Store id: 803260dc-d036-4f9d-896d-4aeb8e04d78d

## Text

```text
def __init__(self, *args, **kwargs)
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
- posted_at: `2026-11-09T23:31:56.8915420+00:00`

## Data

```json
{
  "end_line": 2879,
  "entity_kind": "method",
  "parent": "AutoFieldMixin",
  "start_line": 2877,
  "symbol": "AutoFieldMixin.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2877,"selector":"L2877-L2879","symbol":"AutoFieldMixin.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::AutoFieldMixin.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2879,
    "entity_kind": "method",
    "parent": "AutoFieldMixin",
    "start_line": 2877,
    "symbol": "AutoFieldMixin.__init__"
  },
  "id": "803260dc-d036-4f9d-896d-4aeb8e04d78d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.8915420+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2877,
        "selector": "L2877-L2879",
        "symbol": "AutoFieldMixin.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "0dcb679f-fce5-4784-a803-f49833597e49",
  "subject_name": "django/db/models/fields/__init__::AutoFieldMixin.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, *args, **kwargs)"
}
```
