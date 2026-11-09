# Fact c52d647d

Store id: a2c1d64d-2f2e-4307-a1bd-22b8d451021c

## Text

```text
contains class OuterRef
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
- posted_at: `2026-11-09T23:31:56.0452560+00:00`

## Refs

- rel: contains
  - kind: subject
  - target: [django/db/models/expressions::OuterRef](../../django-db-models-expressions-outerref/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":983,"symbol":"OuterRef"}`

## Referenced by

None.

## Subject

[django/db/models/expressions](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "a2c1d64d-2f2e-4307-a1bd-22b8d451021c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.0452560+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "subject",
      "locator": {
        "line": 983,
        "symbol": "OuterRef"
      },
      "rel": "contains",
      "target": "073b44c2-2a51-4fc4-9865-b3e4df8d2bda"
    }
  ],
  "status": "live",
  "subject_id": "191e4ce1-7784-4937-a266-0e0cfc932363",
  "subject_name": "django/db/models/expressions",
  "tags": [
    "entity:class"
  ],
  "text": "contains class OuterRef"
}
```
