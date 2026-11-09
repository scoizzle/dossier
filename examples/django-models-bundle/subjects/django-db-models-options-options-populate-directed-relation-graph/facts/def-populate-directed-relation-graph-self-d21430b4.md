# Fact d21430b4

Store id: e54b8fea-fa1f-4821-b4db-99d332568a0e

## Text

```text
def _populate_directed_relation_graph(self)
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
- posted_at: `2026-11-09T22:39:48.9194650+00:00`

## Data

```json
{
  "end_line": 846,
  "entity_kind": "method",
  "parent": "Options",
  "start_line": 808,
  "symbol": "Options._populate_directed_relation_graph"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/options.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":808,"selector":"L808-L846","symbol":"Options._populate_directed_relation_graph"}`

## Items

```json
[
  {
    "text": "This method is used by each model to find its reverse objects. As this method is very expensive and is accessed frequently (it looks up every field in a model, in every app), it is computed on first access and then is set as a property on every model.",
    "locator": {
      "line": 809
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/options::Options._populate_directed_relation_graph](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 846,
    "entity_kind": "method",
    "parent": "Options",
    "start_line": 808,
    "symbol": "Options._populate_directed_relation_graph"
  },
  "id": "e54b8fea-fa1f-4821-b4db-99d332568a0e",
  "items": [
    {
      "locator": {
        "line": 809
      },
      "text": "This method is used by each model to find its reverse objects. As this method is very expensive and is accessed frequently (it looks up every field in a model, in every app), it is computed on first access and then is set as a property on every model."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.9194650+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 808,
        "selector": "L808-L846",
        "symbol": "Options._populate_directed_relation_graph"
      },
      "rel": "derived_from",
      "target": "django/db/models/options.py"
    }
  ],
  "status": "live",
  "subject_id": "f0d810c1-15ae-4576-9be3-a0837ad1685c",
  "subject_name": "django/db/models/options::Options._populate_directed_relation_graph",
  "tags": [
    "entity:method"
  ],
  "text": "def _populate_directed_relation_graph(self)"
}
```
