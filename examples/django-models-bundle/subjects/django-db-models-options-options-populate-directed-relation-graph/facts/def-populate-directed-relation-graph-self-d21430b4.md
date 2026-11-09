# Fact d21430b4

Store id: 49053e5b-ad1d-40b6-b598-e3518cc20d86

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
- posted_at: `2026-11-09T23:32:04.0228280+00:00`

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
  "id": "49053e5b-ad1d-40b6-b598-e3518cc20d86",
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
    "posted_at": "2026-11-09T23:32:04.0228280+00:00"
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
  "subject_id": "912ae26e-a8bf-43cf-8dcb-55b4bf7df4f0",
  "subject_name": "django/db/models/options::Options._populate_directed_relation_graph",
  "tags": [
    "entity:method"
  ],
  "text": "def _populate_directed_relation_graph(self)"
}
```
