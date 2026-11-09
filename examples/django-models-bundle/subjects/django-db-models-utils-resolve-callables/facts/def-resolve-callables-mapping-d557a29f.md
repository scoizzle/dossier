# Fact d557a29f

Store id: 51036d3c-c727-41d3-9bad-a9a1dd1ac704

## Text

```text
def resolve_callables(mapping)
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
- posted_at: `2026-11-09T23:45:00.0284050+00:00`

## Data

```json
{
  "end_line": 34,
  "entity_kind": "function",
  "parent": "utils",
  "start_line": 28,
  "symbol": "resolve_callables"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/utils.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":28,"selector":"L28-L34","symbol":"resolve_callables"}`

## Items

```json
[
  {
    "text": "Generate key/value pairs for the given mapping where the values are evaluated if they're callable.",
    "locator": {
      "line": 29
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/utils::resolve_callables](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 34,
    "entity_kind": "function",
    "parent": "utils",
    "start_line": 28,
    "symbol": "resolve_callables"
  },
  "id": "51036d3c-c727-41d3-9bad-a9a1dd1ac704",
  "items": [
    {
      "locator": {
        "line": 29
      },
      "text": "Generate key/value pairs for the given mapping where the values are evaluated if they're callable."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:45:00.0284050+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 28,
        "selector": "L28-L34",
        "symbol": "resolve_callables"
      },
      "rel": "derived_from",
      "target": "django/db/models/utils.py"
    }
  ],
  "status": "live",
  "subject_id": "4f4f83dd-c45c-4b2d-9fa2-57b90d550e62",
  "subject_name": "django/db/models/utils::resolve_callables",
  "tags": [
    "entity:function"
  ],
  "text": "def resolve_callables(mapping)"
}
```
