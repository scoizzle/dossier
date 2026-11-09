# Fact 234c82e6

Store id: 5a6db72f-302a-4762-8a51-761b0fbe7d8a

## Text

```text
def __instancecheck__(self, instance)
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
- posted_at: `2026-11-09T22:39:42.7460610+00:00`

## Data

```json
{
  "end_line": 2955,
  "entity_kind": "method",
  "parent": "AutoFieldMeta",
  "start_line": 2952,
  "symbol": "AutoFieldMeta.__instancecheck__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2952,"selector":"L2952-L2955","symbol":"AutoFieldMeta.__instancecheck__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::AutoFieldMeta.__instancecheck__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2955,
    "entity_kind": "method",
    "parent": "AutoFieldMeta",
    "start_line": 2952,
    "symbol": "AutoFieldMeta.__instancecheck__"
  },
  "id": "5a6db72f-302a-4762-8a51-761b0fbe7d8a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.7460610+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2952,
        "selector": "L2952-L2955",
        "symbol": "AutoFieldMeta.__instancecheck__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "cf1cd688-b5d9-43e2-961a-aae17aa6b5c5",
  "subject_name": "django/db/models/fields/__init__::AutoFieldMeta.__instancecheck__",
  "tags": [
    "entity:method"
  ],
  "text": "def __instancecheck__(self, instance)"
}
```
