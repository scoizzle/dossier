# Fact 7206d9ea

Store id: 9b901767-c3b3-4d83-b858-e2de1ab42d20

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
- posted_at: `2026-11-09T23:44:50.9853120+00:00`

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
  "id": "9b901767-c3b3-4d83-b858-e2de1ab42d20",
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
    "posted_at": "2026-11-09T23:44:50.9853120+00:00"
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
  "subject_id": "c73d62b0-35a6-40b3-8aea-c6897768606f",
  "subject_name": "django/db/models/fields/json::CaseInsensitiveMixin",
  "tags": [
    "entity:class"
  ],
  "text": "class CaseInsensitiveMixin"
}
```
