# Fact a1f82bd3

Store id: 69385e00-48c0-4610-8cdf-4ef894cfe2e4

## Text

```text
class OneToOneField(ForeignKey)
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
- posted_at: `2026-11-09T22:39:44.4252040+00:00`

## Data

```json
{
  "end_line": 1398,
  "entity_kind": "class",
  "parent": "related",
  "start_line": 1351,
  "symbol": "OneToOneField"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1351,"selector":"L1351-L1398","symbol":"OneToOneField"}`

## Items

```json
[
  {
    "text": "A OneToOneField is essentially the same as a ForeignKey, with the exception that it always carries a \"unique\" constraint with it and the reverse relation always returns the object pointed to (since there will only ever be one), rather than returning a list.",
    "locator": {
      "line": 1352
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/related::OneToOneField](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1398,
    "entity_kind": "class",
    "parent": "related",
    "start_line": 1351,
    "symbol": "OneToOneField"
  },
  "id": "69385e00-48c0-4610-8cdf-4ef894cfe2e4",
  "items": [
    {
      "locator": {
        "line": 1352
      },
      "text": "A OneToOneField is essentially the same as a ForeignKey, with the exception that it always carries a \"unique\" constraint with it and the reverse relation always returns the object pointed to (since there will only ever be one), rather than returning a list."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.4252040+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1351,
        "selector": "L1351-L1398",
        "symbol": "OneToOneField"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "b2cad620-6b88-4b64-9d46-adb5d25094c9",
  "subject_name": "django/db/models/fields/related::OneToOneField",
  "tags": [
    "entity:class"
  ],
  "text": "class OneToOneField(ForeignKey)"
}
```
