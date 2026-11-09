# Fact 2638b823

Store id: e053f089-9482-4af4-8bc4-35ebd97f086b

## Text

```text
class SlugField(CharField)
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
- posted_at: `2026-11-09T23:44:50.2261040+00:00`

## Data

```json
{
  "end_line": 2521,
  "entity_kind": "class",
  "parent": "__init__",
  "start_line": 2487,
  "symbol": "SlugField"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2487,"selector":"L2487-L2521","symbol":"SlugField"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::SlugField](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2521,
    "entity_kind": "class",
    "parent": "__init__",
    "start_line": 2487,
    "symbol": "SlugField"
  },
  "id": "e053f089-9482-4af4-8bc4-35ebd97f086b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.2261040+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2487,
        "selector": "L2487-L2521",
        "symbol": "SlugField"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "f5120c3b-12df-48b0-a347-3cd593257baa",
  "subject_name": "django/db/models/fields/__init__::SlugField",
  "tags": [
    "entity:class"
  ],
  "text": "class SlugField(CharField)"
}
```
