# Fact 3e34c902

Store id: b33da26a-7a82-4e94-8864-f87695200a43

## Text

```text
def subclasses(cls)
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
- posted_at: `2026-11-09T23:44:56.4781250+00:00`

## Data

```json
{
  "end_line": 38,
  "entity_kind": "function",
  "parent": "query_utils",
  "start_line": 35,
  "symbol": "subclasses"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query_utils.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":35,"selector":"L35-L38","symbol":"subclasses"}`

## Referenced by

None.

## Subject

[django/db/models/query_utils::subclasses](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 38,
    "entity_kind": "function",
    "parent": "query_utils",
    "start_line": 35,
    "symbol": "subclasses"
  },
  "id": "b33da26a-7a82-4e94-8864-f87695200a43",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:56.4781250+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 35,
        "selector": "L35-L38",
        "symbol": "subclasses"
      },
      "rel": "derived_from",
      "target": "django/db/models/query_utils.py"
    }
  ],
  "status": "live",
  "subject_id": "42fb977b-7801-49b0-b1da-827977821190",
  "subject_name": "django/db/models/query_utils::subclasses",
  "tags": [
    "entity:function"
  ],
  "text": "def subclasses(cls)"
}
```
