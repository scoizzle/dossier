# Fact 7206d9ea

Store id: 7f08caa3-bbb5-4303-8342-437203f96fee

## Text

```text
class CaseInsensitiveMixin
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
- posted_at: `2026-11-09T23:31:57.9144400+00:00`

## Data

```json
{
  "end_line": 312,
  "entity_kind": "class",
  "parent": "json",
  "start_line": 294,
  "symbol": "CaseInsensitiveMixin"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":294,"selector":"L294-L312","symbol":"CaseInsensitiveMixin"}`

## Items

```json
[
  {
    "text": "Mixin to allow case-insensitive comparison of JSON values on MySQL. MySQL handles strings used in JSON context using the utf8mb4_bin collation. Because utf8mb4_bin is a binary collation, comparison of JSON values is case-sensitive.",
    "locator": {
      "line": 295
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/json::CaseInsensitiveMixin](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 312,
    "entity_kind": "class",
    "parent": "json",
    "start_line": 294,
    "symbol": "CaseInsensitiveMixin"
  },
  "id": "7f08caa3-bbb5-4303-8342-437203f96fee",
  "items": [
    {
      "locator": {
        "line": 295
      },
      "text": "Mixin to allow case-insensitive comparison of JSON values on MySQL. MySQL handles strings used in JSON context using the utf8mb4_bin collation. Because utf8mb4_bin is a binary collation, comparison of JSON values is case-sensitive."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.9144400+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 294,
        "selector": "L294-L312",
        "symbol": "CaseInsensitiveMixin"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "8dd8f51c-617b-4b41-bea8-7ea6c31229f6",
  "subject_name": "django/db/models/fields/json::CaseInsensitiveMixin",
  "tags": [
    "entity:class"
  ],
  "text": "class CaseInsensitiveMixin"
}
```
