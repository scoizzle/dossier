# Fact 85176499

Store id: 8041dd0f-8ddf-45b2-b0da-161e25b2c9a0

## Text

```text
def _traverse_ancestors(model, starting_instance)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:function`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:51.8186210+00:00`

## Data

```json
{
  "end_line": 129,
  "entity_kind": "function",
  "parent": "related_descriptors",
  "start_line": 120,
  "symbol": "_traverse_ancestors"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":120,"selector":"L120-L129","symbol":"_traverse_ancestors"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::_traverse_ancestors](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 129,
    "entity_kind": "function",
    "parent": "related_descriptors",
    "start_line": 120,
    "symbol": "_traverse_ancestors"
  },
  "id": "8041dd0f-8ddf-45b2-b0da-161e25b2c9a0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.8186210+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 120,
        "selector": "L120-L129",
        "symbol": "_traverse_ancestors"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "178e2b53-4a15-4720-b47c-334134b2a3cc",
  "subject_name": "django/db/models/fields/related_descriptors::_traverse_ancestors",
  "tags": [
    "entity:function"
  ],
  "text": "def _traverse_ancestors(model, starting_instance)"
}
```
