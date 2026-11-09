# Fact fa764a9c

Store id: 987e80e5-9166-4edd-b14e-351a2d712d2b

## Text

```text
def __set__(self, instance, values)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:31:57.1165000+00:00`

## Data

```json
{
  "end_line": 47,
  "entity_kind": "method",
  "parent": "CompositeAttribute",
  "start_line": 34,
  "symbol": "CompositeAttribute.__set__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/composite.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":34,"selector":"L34-L47","symbol":"CompositeAttribute.__set__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/composite::CompositeAttribute.__set__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 47,
    "entity_kind": "method",
    "parent": "CompositeAttribute",
    "start_line": 34,
    "symbol": "CompositeAttribute.__set__"
  },
  "id": "987e80e5-9166-4edd-b14e-351a2d712d2b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.1165000+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 34,
        "selector": "L34-L47",
        "symbol": "CompositeAttribute.__set__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/composite.py"
    }
  ],
  "status": "live",
  "subject_id": "cf814e8a-bfb6-46ec-9bd1-48897be6ecf8",
  "subject_name": "django/db/models/fields/composite::CompositeAttribute.__set__",
  "tags": [
    "entity:method"
  ],
  "text": "def __set__(self, instance, values)"
}
```
