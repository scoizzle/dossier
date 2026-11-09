# Fact 877ad2fe

Store id: ec7f254f-448e-4760-a63a-1d0e562c40e5

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
- posted_at: `2026-11-09T22:39:42.5950930+00:00`

## Data

```json
{
  "end_line": 2405,
  "entity_kind": "method",
  "parent": "NullBooleanField",
  "start_line": 2402,
  "symbol": "NullBooleanField.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2402,"selector":"L2402-L2405","symbol":"NullBooleanField.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::NullBooleanField.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2405,
    "entity_kind": "method",
    "parent": "NullBooleanField",
    "start_line": 2402,
    "symbol": "NullBooleanField.__init__"
  },
  "id": "ec7f254f-448e-4760-a63a-1d0e562c40e5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.5950930+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2402,
        "selector": "L2402-L2405",
        "symbol": "NullBooleanField.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "1e59c58d-02d3-4f91-b25f-38fa7b830a80",
  "subject_name": "django/db/models/fields/__init__::NullBooleanField.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, *args, **kwargs)"
}
```
