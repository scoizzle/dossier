# Fact f17a550d

Store id: d7993aa4-216e-46bd-9b23-a31ac52e9f1e

## Text

```text
def __init__(self, verbose_name=None, name=None, **kwargs)
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
- posted_at: `2026-11-09T22:39:42.6812850+00:00`

## Data

```json
{
  "end_line": 2725,
  "entity_kind": "method",
  "parent": "URLField",
  "start_line": 2723,
  "symbol": "URLField.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2723,"selector":"L2723-L2725","symbol":"URLField.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::URLField.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2725,
    "entity_kind": "method",
    "parent": "URLField",
    "start_line": 2723,
    "symbol": "URLField.__init__"
  },
  "id": "d7993aa4-216e-46bd-9b23-a31ac52e9f1e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.6812850+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2723,
        "selector": "L2723-L2725",
        "symbol": "URLField.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "77ef2215-822b-4531-8db4-a2a1d5cf1caf",
  "subject_name": "django/db/models/fields/__init__::URLField.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, verbose_name=None, name=None, **kwargs)"
}
```
