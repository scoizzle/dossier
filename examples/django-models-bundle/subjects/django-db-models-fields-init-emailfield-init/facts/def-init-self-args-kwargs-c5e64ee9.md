# Fact c5e64ee9

Store id: 7f7679d4-3195-477e-aacc-8a0f9406f111

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
- posted_at: `2026-11-09T23:31:56.6616660+00:00`

## Data

```json
{
  "end_line": 2004,
  "entity_kind": "method",
  "parent": "EmailField",
  "start_line": 2001,
  "symbol": "EmailField.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2001,"selector":"L2001-L2004","symbol":"EmailField.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::EmailField.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2004,
    "entity_kind": "method",
    "parent": "EmailField",
    "start_line": 2001,
    "symbol": "EmailField.__init__"
  },
  "id": "7f7679d4-3195-477e-aacc-8a0f9406f111",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.6616660+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2001,
        "selector": "L2001-L2004",
        "symbol": "EmailField.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "1cc387a0-3aeb-434a-b3ad-209a9eda7bb1",
  "subject_name": "django/db/models/fields/__init__::EmailField.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, *args, **kwargs)"
}
```
