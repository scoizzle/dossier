# Fact ad1d36cb

Store id: 85d06e78-e172-4efd-aae7-100a4d4ef9c8

## Text

```text
class ResolvedOuterRef(F)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:49.4894660+00:00`

## Data

```json
{
  "end_line": 980,
  "entity_kind": "class",
  "parent": "expressions",
  "start_line": 946,
  "symbol": "ResolvedOuterRef"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":946,"selector":"L946-L980","symbol":"ResolvedOuterRef"}`

## Items

```json
[
  {
    "text": "An object that contains a reference to an outer query.",
    "locator": {
      "line": 947
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/expressions::ResolvedOuterRef](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 980,
    "entity_kind": "class",
    "parent": "expressions",
    "start_line": 946,
    "symbol": "ResolvedOuterRef"
  },
  "id": "85d06e78-e172-4efd-aae7-100a4d4ef9c8",
  "items": [
    {
      "locator": {
        "line": 947
      },
      "text": "An object that contains a reference to an outer query."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.4894660+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 946,
        "selector": "L946-L980",
        "symbol": "ResolvedOuterRef"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "fbeca020-6313-4159-bcb2-dbf545d5a7f9",
  "subject_name": "django/db/models/expressions::ResolvedOuterRef",
  "tags": [
    "entity:class"
  ],
  "text": "class ResolvedOuterRef(F)"
}
```
