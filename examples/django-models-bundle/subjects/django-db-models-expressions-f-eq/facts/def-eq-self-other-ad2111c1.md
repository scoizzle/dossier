# Fact ad2111c1

Store id: 203e2bd0-ad90-4e8c-8382-c3320b08f4f0

## Text

```text
def __eq__(self, other)
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
- posted_at: `2026-11-09T22:39:41.5647790+00:00`

## Data

```json
{
  "end_line": 937,
  "entity_kind": "method",
  "parent": "F",
  "start_line": 936,
  "symbol": "F.__eq__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":936,"selector":"L936-L937","symbol":"F.__eq__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::F.__eq__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 937,
    "entity_kind": "method",
    "parent": "F",
    "start_line": 936,
    "symbol": "F.__eq__"
  },
  "id": "203e2bd0-ad90-4e8c-8382-c3320b08f4f0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.5647790+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 936,
        "selector": "L936-L937",
        "symbol": "F.__eq__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "7c67231e-8683-4790-9435-d0ef5f054876",
  "subject_name": "django/db/models/expressions::F.__eq__",
  "tags": [
    "entity:method"
  ],
  "text": "def __eq__(self, other)"
}
```
