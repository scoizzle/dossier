# Fact c533c0a9

Store id: 5146797c-ba69-49ca-992e-a31a426425bc

## Text

```text
def __repr__(self)
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
- posted_at: `2026-11-09T23:44:49.6758960+00:00`

## Data

```json
{
  "end_line": 2116,
  "entity_kind": "method",
  "parent": "Window",
  "start_line": 2115,
  "symbol": "Window.__repr__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2115,"selector":"L2115-L2116","symbol":"Window.__repr__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Window.__repr__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2116,
    "entity_kind": "method",
    "parent": "Window",
    "start_line": 2115,
    "symbol": "Window.__repr__"
  },
  "id": "5146797c-ba69-49ca-992e-a31a426425bc",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.6758960+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2115,
        "selector": "L2115-L2116",
        "symbol": "Window.__repr__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "ca9a35b8-fd3d-41af-9377-c15a40d3fc8e",
  "subject_name": "django/db/models/expressions::Window.__repr__",
  "tags": [
    "entity:method"
  ],
  "text": "def __repr__(self)"
}
```
