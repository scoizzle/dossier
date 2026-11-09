# Fact ad1d36cb

Store id: aee84106-af5d-4f4e-9688-8f16c1b4499c

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
- posted_at: `2026-11-09T23:31:55.8410620+00:00`

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
  "id": "aee84106-af5d-4f4e-9688-8f16c1b4499c",
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
    "posted_at": "2026-11-09T23:31:55.8410620+00:00"
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
  "subject_id": "a0f4850f-686f-4dc9-9156-7b49df01a1c1",
  "subject_name": "django/db/models/expressions::ResolvedOuterRef",
  "tags": [
    "entity:class"
  ],
  "text": "class ResolvedOuterRef(F)"
}
```
