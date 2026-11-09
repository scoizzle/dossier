# Fact b5129387

Store id: e1c7b7ca-7368-471d-95c1-5c4539f7ad30

## Text

```text
class StrIndex(Func)
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
- posted_at: `2026-11-09T22:39:47.1982020+00:00`

## Data

```json
{
  "end_line": 342,
  "entity_kind": "class",
  "parent": "text",
  "start_line": 330,
  "symbol": "StrIndex"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/text.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":330,"selector":"L330-L342","symbol":"StrIndex"}`

## Items

```json
[
  {
    "text": "Return a positive integer corresponding to the 1-indexed position of the first occurrence of a substring inside another string, or 0 if the substring is not found.",
    "locator": {
      "line": 331
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/functions/text::StrIndex](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 342,
    "entity_kind": "class",
    "parent": "text",
    "start_line": 330,
    "symbol": "StrIndex"
  },
  "id": "e1c7b7ca-7368-471d-95c1-5c4539f7ad30",
  "items": [
    {
      "locator": {
        "line": 331
      },
      "text": "Return a positive integer corresponding to the 1-indexed position of the first occurrence of a substring inside another string, or 0 if the substring is not found."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:47.1982020+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 330,
        "selector": "L330-L342",
        "symbol": "StrIndex"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/text.py"
    }
  ],
  "status": "live",
  "subject_id": "ae141f1f-c104-4514-a906-d99406a7ce17",
  "subject_name": "django/db/models/functions/text::StrIndex",
  "tags": [
    "entity:class"
  ],
  "text": "class StrIndex(Func)"
}
```
