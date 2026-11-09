# Fact 5d706a37

Store id: 3cb6be97-54d8-44d6-b558-f9449d8ece64

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
- posted_at: `2026-11-09T22:39:41.7828640+00:00`

## Data

```json
{
  "end_line": 2190,
  "entity_kind": "method",
  "parent": "WindowFrame",
  "start_line": 2189,
  "symbol": "WindowFrame.__repr__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2189,"selector":"L2189-L2190","symbol":"WindowFrame.__repr__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::WindowFrame.__repr__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2190,
    "entity_kind": "method",
    "parent": "WindowFrame",
    "start_line": 2189,
    "symbol": "WindowFrame.__repr__"
  },
  "id": "3cb6be97-54d8-44d6-b558-f9449d8ece64",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.7828640+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2189,
        "selector": "L2189-L2190",
        "symbol": "WindowFrame.__repr__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "91753e8e-0685-45e0-9f5a-0c4996b91e77",
  "subject_name": "django/db/models/expressions::WindowFrame.__repr__",
  "tags": [
    "entity:method"
  ],
  "text": "def __repr__(self)"
}
```
