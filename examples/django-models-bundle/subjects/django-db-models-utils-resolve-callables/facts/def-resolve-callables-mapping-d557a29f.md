# Fact d557a29f

Store id: 0d48f2dd-7898-40a6-83a3-8aff2e42073e

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
- posted_at: `2026-11-09T23:32:07.9060140+00:00`

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
  "id": "0d48f2dd-7898-40a6-83a3-8aff2e42073e",
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
    "posted_at": "2026-11-09T23:32:07.9060140+00:00"
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
  "subject_id": "6e1057ee-cfbe-4ebc-8e57-e60501fac2ee",
  "subject_name": "django/db/models/utils::resolve_callables",
  "tags": [
    "entity:function"
  ],
  "text": "def resolve_callables(mapping)"
}
```
