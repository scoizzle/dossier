# Fact 85176499

Store id: dbb2a3a0-3272-476f-8870-aeba7a8275dd

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
- posted_at: `2026-11-09T22:39:44.6892120+00:00`

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
  "id": "dbb2a3a0-3272-476f-8870-aeba7a8275dd",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.6892120+00:00"
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
  "subject_id": "9b456456-875f-40b9-a4de-602ca120c177",
  "subject_name": "django/db/models/fields/related_descriptors::_traverse_ancestors",
  "tags": [
    "entity:function"
  ],
  "text": "def _traverse_ancestors(model, starting_instance)"
}
```
