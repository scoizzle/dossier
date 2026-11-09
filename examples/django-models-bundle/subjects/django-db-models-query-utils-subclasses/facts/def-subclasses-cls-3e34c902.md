# Fact 3e34c902

Store id: 6fb0244c-184a-4990-9262-1e18f24bd06c

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
- posted_at: `2026-11-09T23:32:05.0130060+00:00`

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
  "id": "6fb0244c-184a-4990-9262-1e18f24bd06c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:05.0130060+00:00"
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
  "subject_id": "cc6fbe6b-1af0-4f95-b273-5f0fbc37b665",
  "subject_name": "django/db/models/query_utils::subclasses",
  "tags": [
    "entity:function"
  ],
  "text": "def subclasses(cls)"
}
```
