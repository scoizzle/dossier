# Fact df62577a

Store id: 45d164a6-eab9-42c2-8875-a44ffe55ea05

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
- posted_at: `2026-11-09T22:39:42.5615470+00:00`

## Data

```json
{
  "end_line": 2279,
  "entity_kind": "method",
  "parent": "IPAddressField",
  "start_line": 2277,
  "symbol": "IPAddressField.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2277,"selector":"L2277-L2279","symbol":"IPAddressField.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::IPAddressField.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2279,
    "entity_kind": "method",
    "parent": "IPAddressField",
    "start_line": 2277,
    "symbol": "IPAddressField.__init__"
  },
  "id": "45d164a6-eab9-42c2-8875-a44ffe55ea05",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.5615470+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2277,
        "selector": "L2277-L2279",
        "symbol": "IPAddressField.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "310af138-8f28-4509-92d2-421f2843b0a3",
  "subject_name": "django/db/models/fields/__init__::IPAddressField.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, *args, **kwargs)"
}
```
